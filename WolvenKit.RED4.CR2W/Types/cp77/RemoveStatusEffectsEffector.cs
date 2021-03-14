using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectsEffector : gameEffector
	{
		private CArray<CString> _effectTypes;
		private CArray<CString> _effectString;
		private CArray<CName> _effectTags;

		[Ordinal(0)] 
		[RED("effectTypes")] 
		public CArray<CString> EffectTypes
		{
			get
			{
				if (_effectTypes == null)
				{
					_effectTypes = (CArray<CString>) CR2WTypeManager.Create("array:String", "effectTypes", cr2w, this);
				}
				return _effectTypes;
			}
			set
			{
				if (_effectTypes == value)
				{
					return;
				}
				_effectTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectString")] 
		public CArray<CString> EffectString
		{
			get
			{
				if (_effectString == null)
				{
					_effectString = (CArray<CString>) CR2WTypeManager.Create("array:String", "effectString", cr2w, this);
				}
				return _effectString;
			}
			set
			{
				if (_effectString == value)
				{
					return;
				}
				_effectString = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("effectTags")] 
		public CArray<CName> EffectTags
		{
			get
			{
				if (_effectTags == null)
				{
					_effectTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "effectTags", cr2w, this);
				}
				return _effectTags;
			}
			set
			{
				if (_effectTags == value)
				{
					return;
				}
				_effectTags = value;
				PropertySet(this);
			}
		}

		public RemoveStatusEffectsEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
