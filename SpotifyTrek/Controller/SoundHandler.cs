using NAudio.Wave;
using System.IO;
using System.Net;
using System.Threading;

namespace SpotifyTrek.Service
{
    public class SoundHandler
    {
        public bool Playing { get; private set; }
        public string SoundTag { get; private set; }

        public SoundHandler()
        {
            Playing = false;
            SoundTag = null;
        }

        public void PlayFromUrl(string url)
        {
            Thread soundThread = new Thread(() => _PlayFromUrl(url));
            soundThread.Start();
            SpinWait.SpinUntil(() => Playing);
        }

        private void _PlayFromUrl(string url)
        {
            using (Stream ms = new MemoryStream())
            {
                using (Stream str =  WebRequest.Create(url).GetResponse().GetResponseStream())
                {
                    byte[] buffer = new byte[600000];
                    int read;
                    while ((read = str.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                }

                Playing = true;
                SoundTag = url;

                ms.Position = 0;
                using(WaveStream blockAlignedStream =
                new BlockAlignReductionStream(
                    WaveFormatConversionStream.CreatePcmStream(
                        new Mp3FileReader(ms))))
                {
                    using(WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(blockAlignedStream);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            SpinWait.SpinUntil(() => !Playing);
                            break;
                        }
                    }
                }
            }
        }

        public void Stop()
        {
            Playing = false;
            SoundTag = null;
        }
    }
}
