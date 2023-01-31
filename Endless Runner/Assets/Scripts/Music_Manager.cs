using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Manager : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip[] songs;
    public float volume;
    [SerializeField] private float trackTimer;
    [SerializeField] private float songsPlayed;
    [SerializeField] private bool[] beenPlayed;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        beenPlayed = new bool[songs.Length];

        if (_audioSource.isPlaying)
            ChangeSong(Random.Range(0, songs.Length));

    }

    // Update is called once per frame
    void Update()
    {
        _audioSource.volume = volume;

        if (_audioSource.isPlaying)
            trackTimer += 1 * Time.deltaTime;

        if (!_audioSource.isPlaying || trackTimer >= _audioSource.clip.length || Input.GetKeyDown(KeyCode. Q))
            ChangeSong(Random.Range(0, songs.Length));

        if (songsPlayed == songs.Length)
        {
            songsPlayed = 0;
            for (int i = 0; i < songs.Length; i++)
            {
                if (i == songs.Length)
                    break;
                else
                    beenPlayed[i] = false;
            }
        }
    }

    public void ChangeSong(int songPicked)
    {
        if (!beenPlayed[songPicked])
        {
            trackTimer = 0;
            songsPlayed++;
            beenPlayed[songPicked] = true;
            _audioSource.clip = songs[songPicked];
            _audioSource.Play();
        }

        else
            _audioSource.Stop();
    }
}
