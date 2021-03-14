using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCTypePrereq : gameIScriptablePrereq
	{
		private CArray<CEnum<gamedataNPCType>> _allowedTypes;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("allowedTypes")] 
		public CArray<CEnum<gamedataNPCType>> AllowedTypes
		{
			get
			{
				if (_allowedTypes == null)
				{
					_allowedTypes = (CArray<CEnum<gamedataNPCType>>) CR2WTypeManager.Create("array:gamedataNPCType", "allowedTypes", cr2w, this);
				}
				return _allowedTypes;
			}
			set
			{
				if (_allowedTypes == value)
				{
					return;
				}
				_allowedTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public NPCTypePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
