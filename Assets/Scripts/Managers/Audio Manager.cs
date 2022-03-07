using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Managers
{
    public class AudioManager : MonoBehaviour
    {
        #region Public Variables



        #endregion

        #region Private Variables

        [SerializeField] float pitchVariationMin = 0.85f;
        [SerializeField] float pitchVariationMax = 1.15f;
        [SerializeField] float volumeVariationMin = 0.85f;
        [SerializeField] float volumeVariationMax = 1.15f;

        #endregion

        public void PlayAudioOneShotVariation(AudioSource source, AudioClip clip)
        {
            float pitchVariation = Random.Range(pitchVariationMin, pitchVariationMax);
            float volumeVariation = Random.Range(volumeVariationMin, volumeVariationMax);

            source.pitch = pitchVariation;
            source.volume = volumeVariation;

            source.PlayOneShot(clip);
        }

        public void PlayAudioOneShotList(AudioSource source, AudioClip[] clips)
        {
            int RandomNum = Random.Range(0, clips.Length);
            AudioClip ChosenClip = clips[RandomNum];
            PlayAudioOneShotVariation(source, ChosenClip);
        }
    }
}
