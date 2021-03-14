using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCLocomotionTypePrereq : gameIScriptablePrereq
	{
		private CArray<CEnum<gamedataLocomotionMode>> _locomotionMode;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("locomotionMode")] 
		public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode
		{
			get
			{
				if (_locomotionMode == null)
				{
					_locomotionMode = (CArray<CEnum<gamedataLocomotionMode>>) CR2WTypeManager.Create("array:gamedataLocomotionMode", "locomotionMode", cr2w, this);
				}
				return _locomotionMode;
			}
			set
			{
				if (_locomotionMode == value)
				{
					return;
				}
				_locomotionMode = value;
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

		public NPCLocomotionTypePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
