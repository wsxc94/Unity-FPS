﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    //에너미 상태
    enum EnemyState
    {
        Idle, Move, Attack, Return, Damaged, Die
    }
    EnemyState state; //에너미 상태변수

    //유용한 기능
    #region "Idel 상태에 필요한 변수들"
    
    #endregion
    
    #region "Move 상태에 필요한 변수들"

    #endregion
    
    #region "Attack 상태에 필요한 변수들"

    #endregion

    #region "Return 상태에 필요한 변수들"

    #endregion

    #region "Damaged 상태에 필요한 변수들"
    
    #endregion

    #region "Die 상태에 필요한 변수들"

    #endregion

    void Start()
    {
        //에너미 상태 초기화
        state = EnemyState.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        //에너미 상태에 따른 행동처리
        switch (state)
        {
            case EnemyState.Idle:
                Idle();
                break;
            case EnemyState.Move:
                Move();
                break;
            case EnemyState.Attack:
                Attack();
                break;
            case EnemyState.Return:
                Return();
                break;
            case EnemyState.Damaged:
                Damaged();
                break;
            case EnemyState.Die:
                Die();
                break;
        }
    }

    //대기상태
    private void Idle()
    {
        //1. 플레이와 일정범위가 되면 이동상태로 변경 (탐지범위)
        //- 플레이어 찾기 (GameObject.Find("Player")) 타겟찾기
        //- 일정범위 20미터 (거리비교 : Distance, magnitude 아무거나 사용)
        //- 상태변경 -> 이동
        //- 상태전환 출력
    }

    //이동상태
    private void Move()
    {
        //1. 플레이어를 향해서 이동 후 공격범위 안에 들어오면 공격상태로 변경
        //2. 플레이어를 추격하더라도 처음위치에서 일정범위를 넘어가면 리턴상태로 변경
        //- 플레이어 처럼 캐릭터컨트롤러를 이용하기
        //- 공격범위 1미터
        //- 상태변경 -> 공격 or 리턴
        //- 상태전환 출력
    }

    //공격상태
    private void Attack()
    {
        //1. 플레이어가 공격범위 안에 있다면 일정한 시간 간격으로 플레이어를 공격
        //2. 플레이어가 공격범위를 벗어나면 이동 상태로 변경
        //- 공격범위 1미터
        //- 상태변경 -> 이동
        //- 상태전환 출력
    }

    //복귀상태
    private void Return()
    {
        //1. 에너미가 플레이어를 추격하더라도 처음위치에서 일정범위를 벗어나면 다시 돌아옴
        //- 처음위치에서 일정범위 30미터
        //- 상태변경
        //- 상태전환 출력
    }

    //피격상태 (Any State)
    private void Damaged()
    {
        //코루틴 사용하자
        //1. 에너미 체력이 1이상일때만 피격받을 수 있단
        //2. 다시 이전상태로 변경
        //- 상태변경
        //- 상태전환 출력
    }

    //죽음상태 (Any State)
    private void Die()
    {
        //코루틴 사용하자
        //1. 체력이 0이하
        //2. 몬스터 오브젝트 삭제
        //- 상태변경
        //- 상태전환 출력
    }
}