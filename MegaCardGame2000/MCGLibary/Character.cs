///////////////////////////////////////////////////////////
//  Character.cs
//  Implementation of the Class NormalAttack
//  Generated by Enterprise Architect
//  Created on:      16-Oct-2017 9:31:31 AM
//  Original author: tbaird
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public abstract class NormalAttack : Attack {

	public NormalAttack(){

	}

	~NormalAttack(){

	}

	/// <summary>
	/// This is an override of the Attack:GetAttackResult()
	/// </summary>
	public int GetAttackResult(){

		return 0;
	}

}//end NormalAttack