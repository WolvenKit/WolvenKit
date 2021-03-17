using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnSubCharacterEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private TweakDBID _subCharacterTDBID;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("subCharacterTDBID")] 
		public TweakDBID SubCharacterTDBID
		{
			get => GetProperty(ref _subCharacterTDBID);
			set => SetProperty(ref _subCharacterTDBID, value);
		}

		public SpawnSubCharacterEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
