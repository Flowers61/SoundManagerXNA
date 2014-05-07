using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SoundManager
{
    public class SoundManager
    {
        private float _volume;
        private bool _play = false;
        private List<Song> _MUSIC;
        private List<SoundEffect> _SOUNDEFFECTS;

        public SoundEffect soundEffect;
        public Song music;
        public bool play { get { return _play; } set { _play = value; } }

        public SoundManager()
        {
            soundEffect = null;
            music = null;
        }

        public void LoadContent(ContentManager Content)
        {
            music = Content.Load<Song>("Music/JW86 -  REBOOT-INDONESIA - 03 Magical Rainbow Castle");
        }

        public void Play()
        {
            MediaPlayer.Play(music);
            MediaPlayer.IsRepeating = true;
            
        }
        public void isPlay()
        {
            if (!_play)
            {
                _play = true;
                Play();
            }

        }
    }
}