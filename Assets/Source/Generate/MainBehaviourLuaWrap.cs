﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MainBehaviourLuaWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MainBehaviourLua), typeof(LuaFramework.View));
		L.RegFunction("set", set);
		L.RegFunction("Set", Set);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MainBehaviourLua obj = (MainBehaviourLua)ToLua.CheckObject<MainBehaviourLua>(L, 1);
			obj.set();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Set(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MainBehaviourLua obj = (MainBehaviourLua)ToLua.CheckObject<MainBehaviourLua>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.Set(arg0);
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

