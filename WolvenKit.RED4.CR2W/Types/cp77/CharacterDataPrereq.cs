using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterDataPrereq : gameIScriptablePrereq
	{
		private TweakDBID _idToCheck;

		[Ordinal(0)] 
		[RED("idToCheck")] 
		public TweakDBID IdToCheck
		{
			get => GetProperty(ref _idToCheck);
			set => SetProperty(ref _idToCheck, value);
		}

		public CharacterDataPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
