using UnityEngine;

public class SoundControler : SingletonMonoBehaviour<SoundControler>
{
    AudioSource[] audioSourceS;
    int count_AudioSource;
    int ii = 1;

    public AudioClip ShootHit;
    public AudioClip HandHit;
    public AudioClip TakeDamageLong;
    public AudioClip StandartHit;
    public AudioClip TakeDamageShort;
    public AudioClip[] die;
    public AudioClip[] bg;
    public AudioClip Lose;
    public AudioClip Win;

    public enum Sound
    {
        ShootHit,
        HandHit,
        TakeDamageLong,
        StandartHit,
        TakeDamageShort,
        die,
        Lose,
        Win,
    }

    protected override void Awake()
    {
        base.Awake();

        audioSourceS = GetComponentsInChildren<AudioSource>();
        count_AudioSource = audioSourceS.Length;

        audioSourceS[0].clip = bg[Random.Range(0, bg.Length)];
        audioSourceS[0].Play();
        audioSourceS[0].loop = true;
        audioSourceS[0].volume = 0.8f;
    }


    public void Go(Sound sound)
    {
        ii++;
        if (ii >= count_AudioSource) ii = 1;

        audioSourceS[ii].Stop();
        switch (sound) {
            case Sound.ShootHit: audioSourceS[ii].clip = ShootHit; break;
            case Sound.HandHit: audioSourceS[ii].clip = HandHit; break;
            case Sound.TakeDamageLong: audioSourceS[ii].clip = TakeDamageLong; break;
            case Sound.StandartHit: audioSourceS[ii].clip = StandartHit; break;
            case Sound.TakeDamageShort: audioSourceS[ii].clip = TakeDamageShort; break;
            case Sound.die: audioSourceS[ii].clip = die[Random.Range(0, die.Length)]; break;
            case Sound.Lose: audioSourceS[ii].clip = Lose; break;
            case Sound.Win: audioSourceS[ii].clip = Win; break;
        }
        audioSourceS[ii].Play();
    }


}
