using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableQuestTrigger : gameObject
	{
		private CName _factName;
		private CBool _onlyDetectsPlayer;

		[Ordinal(40)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(41)] 
		[RED("onlyDetectsPlayer")] 
		public CBool OnlyDetectsPlayer
		{
			get => GetProperty(ref _onlyDetectsPlayer);
			set => SetProperty(ref _onlyDetectsPlayer, value);
		}

		public MovableQuestTrigger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
