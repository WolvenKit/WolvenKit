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
			get => GetProperty(ref _locomotionMode);
			set => SetProperty(ref _locomotionMode, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public NPCLocomotionTypePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
