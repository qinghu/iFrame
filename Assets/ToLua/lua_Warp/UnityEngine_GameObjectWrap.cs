﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_GameObjectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.GameObject), typeof(UnityEngine.Object));
		L.RegFunction("CreatePrimitive", CreatePrimitive);
		L.RegFunction("GetComponent", GetComponent);
		L.RegFunction("GetComponentInChildren", GetComponentInChildren);
		L.RegFunction("GetComponentInParent", GetComponentInParent);
		L.RegFunction("GetComponents", GetComponents);
		L.RegFunction("GetComponentsInChildren", GetComponentsInChildren);
		L.RegFunction("GetComponentsInParent", GetComponentsInParent);
		L.RegFunction("SetActive", SetActive);
		L.RegFunction("CompareTag", CompareTag);
		L.RegFunction("FindGameObjectWithTag", FindGameObjectWithTag);
		L.RegFunction("FindWithTag", FindWithTag);
		L.RegFunction("FindGameObjectsWithTag", FindGameObjectsWithTag);
		L.RegFunction("SendMessageUpwards", SendMessageUpwards);
		L.RegFunction("BroadcastMessage", BroadcastMessage);
		L.RegFunction("AddComponent", AddComponent);
		L.RegFunction("Find", Find);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("New", _CreateUnityEngine_GameObject);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("transform", get_transform, null);
		L.RegVar("layer", get_layer, set_layer);
		L.RegVar("activeSelf", get_activeSelf, null);
		L.RegVar("activeInHierarchy", get_activeInHierarchy, null);
		L.RegVar("isStatic", get_isStatic, set_isStatic);
		L.RegVar("tag", get_tag, set_tag);
		L.RegVar("scene", get_scene, null);
		L.RegVar("gameObject", get_gameObject, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_GameObject(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.GameObject obj = new UnityEngine.GameObject();
				ToLua.Push(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.GameObject obj = new UnityEngine.GameObject(arg0);
				ToLua.Push(L, obj);
				return 1;
			}
			else if (TypeChecker.CheckTypes(L, 1, typeof(string)) && TypeChecker.CheckParamsType(L, typeof(System.Type), 2, count - 1))
			{
				string arg0 = ToLua.CheckString(L, 1);
				System.Type[] arg1 = ToLua.CheckParamsObject<System.Type>(L, 2, count - 1);
				UnityEngine.GameObject obj = new UnityEngine.GameObject(arg0, arg1);
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.GameObject.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePrimitive(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.PrimitiveType arg0 = (UnityEngine.PrimitiveType)ToLua.CheckObject(L, 1, typeof(UnityEngine.PrimitiveType));
			UnityEngine.GameObject o = UnityEngine.GameObject.CreatePrimitive(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.Component o = obj.GetComponent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component o = obj.GetComponent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.GetComponent");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInChildren(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component o = obj.GetComponentInChildren(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type), typeof(bool)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Component o = obj.GetComponentInChildren(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.GetComponentInChildren");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInParent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 2, typeof(System.Type));
			UnityEngine.Component o = obj.GetComponentInParent(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponents(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component[] o = obj.GetComponents(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type), typeof(System.Collections.Generic.List<UnityEngine.Component>)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				System.Collections.Generic.List<UnityEngine.Component> arg1 = (System.Collections.Generic.List<UnityEngine.Component>)ToLua.ToObject(L, 3);
				obj.GetComponents(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.GetComponents");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInChildren(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component[] o = obj.GetComponentsInChildren(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type), typeof(bool)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Component[] o = obj.GetComponentsInChildren(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.GetComponentsInChildren");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInParent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component[] o = obj.GetComponentsInParent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(System.Type), typeof(bool)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Component[] o = obj.GetComponentsInParent(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.GetComponentsInParent");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetActive(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.SetActive(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareTag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.CompareTag(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindGameObjectWithTag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.GameObject o = UnityEngine.GameObject.FindGameObjectWithTag(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindWithTag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.GameObject o = UnityEngine.GameObject.FindWithTag(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindGameObjectsWithTag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.GameObject[] o = UnityEngine.GameObject.FindGameObjectsWithTag(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessageUpwards(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.SendMessageUpwards(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessageUpwards(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(object)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessageUpwards(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(object), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 4);
				obj.SendMessageUpwards(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.SendMessageUpwards");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BroadcastMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.BroadcastMessage(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.BroadcastMessage(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(object)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.BroadcastMessage(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(object), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 4);
				obj.BroadcastMessage(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.BroadcastMessage");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddComponent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 2, typeof(System.Type));
			UnityEngine.Component o = obj.AddComponent(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.GameObject o = UnityEngine.GameObject.Find(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		try
		{
            ++LuaException.SendMsgCount;
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
                obj.SendMessage(arg0);
                --LuaException.SendMsgCount;

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.luaStack);
                }
                
                return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessage(arg0, arg1);
                --LuaException.SendMsgCount;

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.luaStack);
                }

                return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(object)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessage(arg0, arg1);
                --LuaException.SendMsgCount;

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.luaStack);
                }

                return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string), typeof(object), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.GameObject obj = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 4);
				obj.SendMessage(arg0, arg1, arg2);
                --LuaException.SendMsgCount;

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.luaStack);
                }

                return 0;
			}
			else
			{
                --LuaException.SendMsgCount;                                
                return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.GameObject.SendMessage");     
			}
		}
		catch(Exception e)
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
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			UnityEngine.Transform ret = obj.transform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index transform on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			int ret = obj.layer;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index layer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeSelf(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			bool ret = obj.activeSelf;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index activeSelf on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeInHierarchy(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			bool ret = obj.activeInHierarchy;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index activeInHierarchy on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isStatic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			bool ret = obj.isStatic;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isStatic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			string ret = obj.tag;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index tag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scene(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			UnityEngine.SceneManagement.Scene ret = obj.scene;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scene on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			UnityEngine.GameObject ret = obj.gameObject;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index gameObject on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_layer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.layer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index layer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isStatic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isStatic = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isStatic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.GameObject obj = (UnityEngine.GameObject)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.tag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index tag on a nil value" : e.Message);
		}
	}
}

