///////////////////////////////////////////////////////////
//  Mage.cs
//  Implementation of the Class BackStab
//  Generated by Enterprise Architect
//  Created on:      16-Oct-2017 9:31:31 AM
//  Original author: tbaird
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class BackStab : SpecialAttack {

	public BackStab(){

	}

	~BackStab(){

	}

	/// <summary>
	/// This is an override of the Attack:GetAttackResult()
	/// 
	/// +ve return is damage applied to NPC
	/// -ve return is damage applied to PC
	/// 0 return is no damage done.
	/// </summary>
	public int GetAttackResult(){

		return 0;
	}

}//end BackStab