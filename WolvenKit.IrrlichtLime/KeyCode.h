#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

	/// <summary>
	/// Keys codes.
	/// </summary>
	public enum class KeyCode
	{
		/// <summary>
		/// Left mouse button.
		/// </summary>
		MouseLButton = KEY_LBUTTON,

		/// <summary>
		/// Right mouse button.
		/// </summary>
		MouseRButton = KEY_RBUTTON,

		/// <summary>
		/// Control-break processing.
		/// </summary>
		Cancel = KEY_CANCEL,

		/// <summary>
		/// Middle mouse button (three-button mouse).
		/// </summary>
		MouseMButton = KEY_MBUTTON,

		/// <summary>
		/// Windows 2000/XP: X1 mouse button.
		/// </summary>
		MouseXButton1 = KEY_XBUTTON1,

		/// <summary>
		/// Windows 2000/XP: X2 mouse button.
		/// </summary>
		MouseXButton2 = KEY_XBUTTON2,

		/// <summary>
		/// BACKSPACE key.
		/// </summary>
		Backspace = KEY_BACK,

		/// <summary>
		/// TAB key.
		/// </summary>
		Tab = KEY_TAB,

		/// <summary>
		/// CLEAR key.
		/// </summary>
		Clear = KEY_CLEAR,

		/// <summary>
		/// ENTER key.
		/// </summary>
		Return = KEY_RETURN,

		/// <summary>
		/// SHIFT key.
		/// </summary>
		Shift = KEY_SHIFT,

		/// <summary>
		/// CTRL key.
		/// </summary>
		Ctrl = KEY_CONTROL,

		/// <summary>
		/// ALT key.
		/// </summary>
		Alt = KEY_MENU,

		/// <summary>
		/// PAUSE key.
		/// </summary>
		Pause = KEY_PAUSE,

		/// <summary>
		/// CAPS LOCK key.
		/// </summary>
		CapsLock = KEY_CAPITAL,

		/// <summary>
		/// IME Kana mode.
		/// </summary>
		IME_Kana = KEY_KANA,

		/// <summary>
		/// IME Hangul mode.
		/// </summary>
		IME_Hangul = KEY_HANGUL,

		/// <summary>
		/// IME Junja mode.
		/// </summary>
		IME_Junja = KEY_JUNJA,

		/// <summary>
		/// IME final mode.
		/// </summary>
		IME_Final = KEY_FINAL,

		/// <summary>
		/// IME Hanja mode.
		/// </summary>
		IME_Hanja = KEY_HANJA,

		/// <summary>
		/// IME Kanji mode.
		/// </summary>
		IME_Kanji = KEY_KANJI,

		/// <summary>
		/// ESC key.
		/// </summary>
		Esc = KEY_ESCAPE,

		/// <summary>
		/// IME convert.
		/// </summary>
		IME_Convert = KEY_CONVERT,

		/// <summary>
		/// IME nonconvert.
		/// </summary>
		IME_NonConvert = KEY_NONCONVERT,

		/// <summary>
		/// IME accept.
		/// </summary>
		IME_Accept = KEY_ACCEPT,

		/// <summary>
		/// IME mode change request.
		/// </summary>
		IME_ModeChange = KEY_MODECHANGE,

		/// <summary>
		/// SPACEBAR key.
		/// </summary>
		Space = KEY_SPACE,

		/// <summary>
		/// PAGE UP key.
		/// </summary>
		PageUp = KEY_PRIOR,

		/// <summary>
		/// PAGE DOWN key.
		/// </summary>
		PageDown = KEY_NEXT,

		/// <summary>
		/// END key.
		/// </summary>
		End = KEY_END,

		/// <summary>
		/// HOME key.
		/// </summary>
		Home = KEY_HOME,

		/// <summary>
		/// LEFT ARROW key.
		/// </summary>
		Left = KEY_LEFT,

		/// <summary>
		/// UP ARROW key.
		/// </summary>
		Up = KEY_UP,

		/// <summary>
		/// RIGHT ARROW key.
		/// </summary>
		Right = KEY_RIGHT,

		/// <summary>
		/// DOWN ARROW key.
		/// </summary>
		Down = KEY_DOWN,

		/// <summary>
		/// SELECT key.
		/// </summary>
		Select = KEY_SELECT,

		/// <summary>
		/// PRINT key.
		/// </summary>
		Print = KEY_PRINT,

		/// <summary>
		/// EXECUTE key.
		/// </summary>
		Execute = KEY_EXECUT,

		/// <summary>
		/// PRINT SCREEN key.
		/// </summary>
		PrintScreen = KEY_SNAPSHOT,

		/// <summary>
		/// INS key.
		/// </summary>
		Insert = KEY_INSERT,

		/// <summary>
		/// DEL key.
		/// </summary>
		Delete = KEY_DELETE,

		/// <summary>
		/// HELP key.
		/// </summary>
		Help = KEY_HELP,

		/// <summary>
		/// 0 key.
		/// </summary>
		Key0 = KEY_KEY_0,

		/// <summary>
		/// 1 key.
		/// </summary>
		Key1 = KEY_KEY_1,

		/// <summary>
		/// 2 key.
		/// </summary>
		Key2 = KEY_KEY_2,

		/// <summary>
		/// 3 key.
		/// </summary>
		Key3 = KEY_KEY_3,

		/// <summary>
		/// 4 key.
		/// </summary>
		Key4 = KEY_KEY_4,

		/// <summary>
		/// 5 key.
		/// </summary>
		Key5 = KEY_KEY_5,

		/// <summary>
		/// 6 key.
		/// </summary>
		Key6 = KEY_KEY_6,

		/// <summary>
		/// 7 key.
		/// </summary>
		Key7 = KEY_KEY_7,

		/// <summary>
		/// 8 key.
		/// </summary>
		Key8 = KEY_KEY_8,

		/// <summary>
		/// 9 key.
		/// </summary>
		Key9 = KEY_KEY_9,

		/// <summary>
		/// A key.
		/// </summary>
		KeyA = KEY_KEY_A,

		/// <summary>
		/// B key.
		/// </summary>
		KeyB = KEY_KEY_B,

		/// <summary>
		/// C key.
		/// </summary>
		KeyC = KEY_KEY_C,

		/// <summary>
		/// D key.
		/// </summary>
		KeyD = KEY_KEY_D,

		/// <summary>
		/// E key.
		/// </summary>
		KeyE = KEY_KEY_E,

		/// <summary>
		/// F key.
		/// </summary>
		KeyF = KEY_KEY_F,

		/// <summary>
		/// G key.
		/// </summary>
		KeyG = KEY_KEY_G,

		/// <summary>
		/// H key.
		/// </summary>
		KeyH = KEY_KEY_H,

		/// <summary>
		/// I key.
		/// </summary>
		KeyI = KEY_KEY_I,

		/// <summary>
		/// J key.
		/// </summary>
		KeyJ = KEY_KEY_J,

		/// <summary>
		/// K key.
		/// </summary>
		KeyK = KEY_KEY_K,

		/// <summary>
		/// L key.
		/// </summary>
		KeyL = KEY_KEY_L,

		/// <summary>
		/// M key.
		/// </summary>
		KeyM = KEY_KEY_M,

		/// <summary>
		/// N key.
		/// </summary>
		KeyN = KEY_KEY_N,

		/// <summary>
		/// O key.
		/// </summary>
		KeyO = KEY_KEY_O,

		/// <summary>
		/// P key.
		/// </summary>
		KeyP = KEY_KEY_P,

		/// <summary>
		/// Q key.
		/// </summary>
		KeyQ = KEY_KEY_Q,

		/// <summary>
		/// R key.
		/// </summary>
		KeyR = KEY_KEY_R,

		/// <summary>
		/// S key.
		/// </summary>
		KeyS = KEY_KEY_S,

		/// <summary>
		/// T key.
		/// </summary>
		KeyT = KEY_KEY_T,

		/// <summary>
		/// U key.
		/// </summary>
		KeyU = KEY_KEY_U,

		/// <summary>
		/// V key.
		/// </summary>
		KeyV = KEY_KEY_V,

		/// <summary>
		/// W key.
		/// </summary>
		KeyW = KEY_KEY_W,

		/// <summary>
		/// X key.
		/// </summary>
		KeyX = KEY_KEY_X,

		/// <summary>
		/// Y key.
		/// </summary>
		KeyY = KEY_KEY_Y,

		/// <summary>
		/// Z key.
		/// </summary>
		KeyZ = KEY_KEY_Z,

		/// <summary>
		/// Left Windows key (Microsoft Natural keyboard).
		/// </summary>
		LWin = KEY_LWIN,

		/// <summary>
		/// Right Windows key (Microsoft Natural keyboard).
		/// </summary>
		RWin = KEY_RWIN,

		/// <summary>
		/// Applications key (Microsoft Natural keyboard).
		/// </summary>
		Apps = KEY_APPS,

		/// <summary>
		/// Computer Sleep key.
		/// </summary>
		Sleep = KEY_SLEEP,

		/// <summary>
		/// Numeric keypad 0 key.
		/// </summary>
		Num0 = KEY_NUMPAD0,

		/// <summary>
		/// Numeric keypad 1 key.
		/// </summary>
		Num1 = KEY_NUMPAD1,

		/// <summary>
		/// Numeric keypad 2 key.
		/// </summary>
		Num2 = KEY_NUMPAD2,

		/// <summary>
		/// Numeric keypad 3 key.
		/// </summary>
		Num3 = KEY_NUMPAD3,

		/// <summary>
		/// Numeric keypad 4 key.
		/// </summary>
		Num4 = KEY_NUMPAD4,

		/// <summary>
		/// Numeric keypad 5 key.
		/// </summary>
		Num5 = KEY_NUMPAD5,

		/// <summary>
		/// Numeric keypad 6 key.
		/// </summary>
		Num6 = KEY_NUMPAD6,

		/// <summary>
		/// Numeric keypad 7 key.
		/// </summary>
		Num7 = KEY_NUMPAD7,

		/// <summary>
		/// Numeric keypad 8 key.
		/// </summary>
		Num8 = KEY_NUMPAD8,

		/// <summary>
		/// Numeric keypad 9 key.
		/// </summary>
		Num9 = KEY_NUMPAD9,

		/// <summary>
		/// Multiply key.
		/// </summary>
		Multiply = KEY_MULTIPLY,

		/// <summary>
		/// Add key.
		/// </summary>
		Add = KEY_ADD,

		/// <summary>
		/// Separator key.
		/// </summary>
		Separator = KEY_SEPARATOR,

		/// <summary>
		/// Subtract key.
		/// </summary>
		Subtract = KEY_SUBTRACT,

		/// <summary>
		/// Decimal key.
		/// </summary>
		Decimal = KEY_DECIMAL,

		/// <summary>
		/// Divide key.
		/// </summary>
		Devide = KEY_DIVIDE,

		/// <summary>
		/// F1 key.
		/// </summary>
		F1 = KEY_F1,

		/// <summary>
		/// F2 key.
		/// </summary>
		F2 = KEY_F2,

		/// <summary>
		/// F3 key.
		/// </summary>
		F3 = KEY_F3,

		/// <summary>
		/// F4 key.
		/// </summary>
		F4 = KEY_F4,

		/// <summary>
		/// F5 key.
		/// </summary>
		F5 = KEY_F5,

		/// <summary>
		/// F6 key.
		/// </summary>
		F6 = KEY_F6,

		/// <summary>
		/// F7 key.
		/// </summary>
		F7 = KEY_F7,

		/// <summary>
		/// F8 key.
		/// </summary>
		F8 = KEY_F8,

		/// <summary>
		/// F9 key.
		/// </summary>
		F9 = KEY_F9,

		/// <summary>
		/// F10 key.
		/// </summary>
		F10 = KEY_F10,

		/// <summary>
		/// F11 key.
		/// </summary>
		F11 = KEY_F11,

		/// <summary>
		/// F12 key.
		/// </summary>
		F12 = KEY_F12,

		/// <summary>
		/// F13 key.
		/// </summary>
		F13 = KEY_F13,

		/// <summary>
		/// F14 key.
		/// </summary>
		F14 = KEY_F14,

		/// <summary>
		/// F15 key.
		/// </summary>
		F15 = KEY_F15,

		/// <summary>
		/// F16 key.
		/// </summary>
		F16 = KEY_F16,

		/// <summary>
		/// F17 key.
		/// </summary>
		F17 = KEY_F17,

		/// <summary>
		/// F18 key.
		/// </summary>
		F18 = KEY_F18,

		/// <summary>
		/// F19 key.
		/// </summary>
		F19 = KEY_F19,

		/// <summary>
		/// F20 key.
		/// </summary>
		F20 = KEY_F20,

		/// <summary>
		/// F21 key.
		/// </summary>
		F21 = KEY_F21,

		/// <summary>
		/// F22 key.
		/// </summary>
		F22 = KEY_F22,

		/// <summary>
		/// F23 key.
		/// </summary>
		F23 = KEY_F23,

		/// <summary>
		/// F24 key.
		/// </summary>
		F24 = KEY_F24,

		/// <summary>
		/// NUM LOCK key.
		/// </summary>
		NumLock = KEY_NUMLOCK,

		/// <summary>
		/// SCROLL LOCK key.
		/// </summary>
		ScrollLock = KEY_SCROLL,

		/// <summary>
		/// Left SHIFT key.
		/// </summary>
		LShift = KEY_LSHIFT,

		/// <summary>
		/// Right SHIFT key.
		/// </summary>
		RShift = KEY_RSHIFT,

		/// <summary>
		/// Left CONTROL key.
		/// </summary>
		LControl = KEY_LCONTROL,

		/// <summary>
		/// Right CONTROL key.
		/// </summary>
		RControl = KEY_RCONTROL,

		/// <summary>
		/// Left MENU key.
		/// </summary>
		LMenu = KEY_LMENU,

		/// <summary>
		/// Right MENU key.
		/// </summary>
		RMenu = KEY_RMENU,

		/// <summary>
		/// for US ";:".
		/// </summary>
		OEM_1 = KEY_OEM_1,

		/// <summary>
		/// Plus Key "+".
		/// </summary>
		Plus = KEY_PLUS,

		/// <summary>
		/// Comma Key ",".
		/// </summary>
		Comma = KEY_COMMA,

		/// <summary>
		/// Minus Key "-".
		/// </summary>
		Minus = KEY_MINUS,

		/// <summary>
		/// Period Key ".".
		/// </summary>
		Period = KEY_PERIOD,

		/// <summary>
		/// for US "/?".
		/// </summary>
		OEM_2 = KEY_OEM_2,

		/// <summary>
		/// for US "`~".
		/// </summary>
		OEM_3 = KEY_OEM_3,

		/// <summary>
		/// Backquote/tilde key.
		/// </summary>
		Backquote = OEM_3,

		/// <summary>
		/// for US "[{".
		/// </summary>
		OEM_4 = KEY_OEM_4,

		/// <summary>
		/// for US "\|".
		/// </summary>
		OEM_5 = KEY_OEM_5,

		/// <summary>
		/// for US "]}".
		/// </summary>
		OEM_6 = KEY_OEM_6,

		/// <summary>
		/// for US "'"".
		/// </summary>
		OEM_7 = KEY_OEM_7,

		/// <summary>
		/// None.
		/// </summary>
		OEM_8 = KEY_OEM_8,

		/// <summary>
		/// for Japan "AX".
		/// </summary>
		OEM_AX = KEY_OEM_AX,

		/// <summary>
		/// "&lt;&gt;" or "\|".
		/// </summary>
		OEM_102 = KEY_OEM_102,

		/// <summary>
		/// Attn key.
		/// </summary>
		Attn = KEY_ATTN,

		/// <summary>
		/// CrSel key.
		/// </summary>
		CrSel = KEY_CRSEL,

		/// <summary>
		/// ExSel key.
		/// </summary>
		ExSel = KEY_EXSEL,

		/// <summary>
		/// Erase EOF key.
		/// </summary>
		ErEOF = KEY_EREOF,

		/// <summary>
		/// Play key.
		/// </summary>
		Play = KEY_PLAY,

		/// <summary>
		/// Zoom key.
		/// </summary>
		Zoom = KEY_ZOOM,

		/// <summary>
		/// PA1 key.
		/// </summary>
		PA1 = KEY_PA1,

		/// <summary>
		/// Clear key.
		/// </summary>
		OEM_Clear = KEY_OEM_CLEAR,

		/// <summary>
		/// Usually no key mapping, but some laptops use it for "fn" key.
		/// </summary>
		None = KEY_NONE
	};

} // end namespace IrrlichtLime
