using System;
using Android.App;
using Android.Media;
using Android.OS;
using Android.Widget;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private AudioTrack _audioTrack;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            using (var pb = FindViewById<Button>(Resource.Id.button_synthe))
            {
                pb.Click += PbOnClick;
            }
        }

        private void PbOnClick(object sender, EventArgs eventArgs)
        {
            using (var textKoe = FindViewById<EditText>(Resource.Id.text_koe))
            {
                using (var textSpeed = FindViewById<EditText>(Resource.Id.text_speed))
                {
                    OnPlayButton(textKoe.Text, Convert.ToInt32(textSpeed.Text));
                }
            }
        }

        private void OnPlayButton(string koe, int speed)
        {
            var wav = new AquesTalk().synthe(koe, speed);
            if (wav.Length == 1)
                return;

            if (_audioTrack != null)
            {
                _audioTrack.Stop();
                _audioTrack.Release();
                _audioTrack.Dispose();
            }

            _audioTrack =
                new AudioTrack(Stream.Music, 8000, ChannelOut.Mono, Encoding.Pcm16bit, wav.Length - 44,
                    AudioTrackMode.Static);

            _audioTrack.Write(wav, 44, wav.Length - 44);
            _audioTrack.Play();
        }
    }
}