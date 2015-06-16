using UnityEngine;
using System.Collections;

public class BuffScript : MonoBehaviour {
    private GameObject _player;
    private GameObject _score;
    private ScoreController _scoreController;
    private PlayerController _playerController;
    public GameObject explosion;
    
    void Start(){
        _player = GameObject.Find("Player");
        _score = GameObject.Find("Main Camera");
        _playerController = (PlayerController)_player.GetComponent("PlayerController");
        _scoreController = (ScoreController)_score.GetComponent("ScoreController");
    }
    void OnCollisionEnter2D(Collision2D coll) 
    {
        
        if (coll.collider.tag == "Player")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            _scoreController.score += 1000;
            Destroy(explosion, 3);
        }/*
        else
        {
            _scoreController.score += 100000;
        }*/
        Destroy(gameObject);
    }



}
