using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject _fireBallPrefab;
    public GameObject _fireParent;
    public float _fireBallSpeed;
    public int _frecuencia;
    public Vector2 Posicion;
    public float _spawnTime;

    // Start is called before the first frame update
    void Start()
    { 
        StartCoroutine(StartFireBalls());
    }

    private IEnumerator StartFireBalls()
    {
        while (GameManager.Instance.gameOver == false)
        {
            yield return new WaitForSeconds(_spawnTime + _frecuencia);
            FireShot();
            randomFrecuencia();
        }
    }

    public void FireShot()
    {
        GameObject _fireball =  Instantiate(_fireBallPrefab, Posicion, Quaternion.identity);
        _fireball.gameObject.transform.SetParent(_fireParent.transform);
        _fireball.GetComponent<FireBallScript>()._speed = _fireBallSpeed;
    }

    public void randomFrecuencia()
    {
        _frecuencia = Random.Range(2, 4);
    }
}
