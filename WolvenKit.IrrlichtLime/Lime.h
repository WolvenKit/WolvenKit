#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace System::Reflection; // for Assembly
using namespace System::Runtime::InteropServices; // for Marshal

#ifdef _DEBUG
#define LIME_ASSERT(condition) System::Diagnostics::Debug::Assert(condition, #condition);
#define LIME_ASSERT2(condition, details) System::Diagnostics::Debug::Assert(condition, #condition, details);
#else
#define LIME_ASSERT(condition) ;
#define LIME_ASSERT2(condition, details) ;
#endif

#define LIME_SAFEREF(object, member) ((object) == nullptr ? nullptr : (object)->member)
#define LIME_SAFEVAL(object, value) ((object) == nullptr ? (value) : *(object)->m_NativeValue)
#define LIME_SAFESTRINGTOSTRINGC_C_STR(string) ((string) == nullptr ? nullptr : Lime::StringToStringC(string).c_str())
#define LIME_SAFESTRINGTOSTRINGW_C_STR(string) ((string) == nullptr ? nullptr : Lime::StringToStringW(string).c_str())

namespace IrrlichtLime {

	/// <summary>
	/// Irrlicht Lime core class. Provides wrapper common functionality.
	/// </summary>
	public ref class Lime
	{
	public:

		template <class T>
		ref class NativeValue
		{
		public:

			~NativeValue()
			{
				this->!NativeValue();
			}

			!NativeValue()
			{
				if (m_DeleteOnFinalize)
					delete m_NativeValue;
			}

		internal:

			T* m_NativeValue;

		protected:

			NativeValue(bool deleteOnFinalize)
			{
				m_DeleteOnFinalize = deleteOnFinalize;
			}

		private:

			bool m_DeleteOnFinalize;
		};

		/// <summary>
		/// Irrlicht Lime version.
		/// </summary>
		static property String^ Version
		{
			String^ get()
			{
				System::Version^ v = Assembly::GetAssembly(Lime::typeid)->GetName()->Version;
				String^ s;

				if (v->Build != 0)
					s = String::Format("{0}.{1}.{2}", v->Major, v->Minor, v->Build);
				else
					s = String::Format("{0}.{1}", v->Major, v->Minor);

#if _DEBUG
#if WIN64
				s += " (Debug-x64)";
#else
				s += " (Debug-x86)";
#endif
#else
#if WIN64
				s += " (Release-x64)";
#else
				s += " (Release-x86)";
#endif
#endif

				return s;
			}
		}

	internal:

		static io::path StringToPath(String^ s)
		{
			return io::path(StringToStringW(s));
		}

		static core::stringc StringToStringC(String^ s)
		{
			LIME_ASSERT(s != nullptr);

			char* c = (char*)Marshal::StringToHGlobalAnsi(s).ToPointer();
			core::stringc strC = core::stringc(c);

			Marshal::FreeHGlobal(IntPtr(c));
			return strC;
		}

		static core::stringw StringToStringW(String^ s)
		{
			LIME_ASSERT(s != nullptr);

			wchar_t* w = (wchar_t*)Marshal::StringToHGlobalUni(s).ToPointer();
			core::stringw strW = core::stringw(w);

			Marshal::FreeHGlobal(IntPtr(w));
			return strW;
		}

	private:

		Lime() {}
	};

} // end namespace IrrlichtLime
