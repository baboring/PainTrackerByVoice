﻿using UnityEngine;

using System;


namespace HC
{
	public class MainStateMain : MainStateBase
	{
		static MainStateMain _instance;
		static public MainStateMain instance { get { return _instance; } }
		MainStateMain()
		{
            Logger.Assert(_instance == null);
			_instance = this;
			eInitialWindows = new WndID[] {
				WndID.WndMain,
				WndID.WndSetting,
			};
		}

		void Awake()
		{
			Logger.InfoFormat("MainStateNone.Awake !!");

		}

		// 해당 상태를 최초 상태로 초기화 하는곳
		override public void Reset()
		{

		}

		override public void OnEnter()
		{
			// Window Load가 없으니 바로 완료
			Action<bool> complete = (success) => OnLoadComplete();
			complete(true);
		}

		override public void OnLeave() { }

		override public void OnUpdate() { }

		override public void OnLoadComplete()
		{
			IsPrearedState = true;
			WindowManager.SetActiveWindow(WndID.WndMain,true);
		}
	}

}