﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_ViewWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.View), typeof(LuaFramework.Base));
		L.RegFunction("OnMessage", OnMessage);
		L.RegFunction("OnclickTalkingDataBegin", OnclickTalkingDataBegin);
		L.RegFunction("OnclickTalkingDataEnd", OnclickTalkingDataEnd);
		L.RegFunction("TrackEvent", TrackEvent);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.View obj = (LuaFramework.View)ToLua.CheckObject<LuaFramework.View>(L, 1);
			IMessage arg0 = (IMessage)ToLua.CheckObject<IMessage>(L, 2);
			obj.OnMessage(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnclickTalkingDataBegin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.View obj = (LuaFramework.View)ToLua.CheckObject<LuaFramework.View>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.OnclickTalkingDataBegin(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnclickTalkingDataEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.View obj = (LuaFramework.View)ToLua.CheckObject<LuaFramework.View>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.OnclickTalkingDataEnd(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TrackEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.View obj = (LuaFramework.View)ToLua.CheckObject<LuaFramework.View>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.TrackEvent(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
