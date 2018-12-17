﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// バトルの攻守決定ステート
/// </summary>
public class BattleStateOffensiveDecision : IBattleState {

	bool isDecision = false;

	public int num;

	public void ExecuteEntry(BattleContext context) {
		Debug.Log("[Entry] Battle State : Offensive Decision");

		isDecision = false;
	}

	public void ExecuteUpdate(BattleContext context) {
		// 出目を検出して互いに同値ならやり直し


		// ステート遷移
		if (isDecision) {
			if (context.isOffense) context.ChangeState(context.stateOffense);
			else context.ChangeState(context.stateDefense);
		}
	}

	public void ExecuteExit(BattleContext context) {
		Debug.Log("[Entry] Battle State : Offensive Decision");
	}

	/// <summary>
	/// 攻守決定処理
	/// </summary>
	void DecideOffense(BattleContext context) {

		isDecision = true;
	}
}
