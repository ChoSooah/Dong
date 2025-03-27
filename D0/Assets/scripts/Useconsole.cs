using UnityEngine;

public class Useconsole : MonoBehaviour
{

    //주석
    /*여러줄 주석*/

    /*
    //변수 표기법

    //Bad Example
    int a;

    float b;

    bool c;

    //Good example

    int stage = 1;

    float bossHp = 10f;

    float playerSpeed = 5f;

    //만약에 이렇게 되어있으면?

    int s = 1;

    float b = 10f;

    float p = 5 f;

    //알아보기 힘들다.


    //______________________________________________


    //표기법들


    //스네이크 표기법 : 뱀처럼 소문자로 길게 쓰는 방법
    //단어와 단어 사이에는 _(언더바)를 사용
    //Ex 1. 유저의 이동속도를 저장하는 실수형 변수

    float player_speed = 0f;


    //카멜 표기법 : 낙타의 등 같이 생긴 표기법. 단어의 첫 글자는 대문자로 쓰되, 첫단어는 소문자로 쓴다.
    //대다수의 프로젝트에서 많이 사용함 (선배 주관)

    float playerSpeed = 10f;


    //파스칼 표기법 : 단어의 첫글자는 대문자로만 쓴다.
    //함수에서 많이 사용용

    void PlayerAttack() { }


    //헝가리안 표기법 : 변수명 앞에 자료형을 표시해준다
    //과거에는 많이 사용. 지금은 MFC말고는 사용처를 잘 모르겠음.

    float fPlayerSpeed = 10.1f;

    //변수는 카멜, 함수는 파스칼로 주로 쓴다. 팀 프로젝트 할떄 참고.

    */





    //________________________________________________________________


    void Start()
    {
        Debug.Log("Hello world");
    }
}