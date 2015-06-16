using UnityEngine;
using System.Collections;

public class BuffScript : MonoBehaviour {
    private GameObject _player;
    private GameObject _score;
    private ScoreController _scoreController;
    private PlayerController _playerController;
    
    void Start(){
        _player = GameObject.Find("Player");
        _score = GameObject.Find("Main Camera");
        _playerController = (PlayerController)_player.GetComponent("PlayerController");
        _scoreController = (ScoreController)_score.GetComponent("ScoreController");
    }



}
