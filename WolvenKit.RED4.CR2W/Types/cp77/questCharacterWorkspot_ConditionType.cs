using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterWorkspot_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private NodeRef _spotRef;
		private CName _animationName;
		private CBool _waitForAnimEnd;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("spotRef")] 
		public NodeRef SpotRef
		{
			get => GetProperty(ref _spotRef);
			set => SetProperty(ref _spotRef, value);
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(4)] 
		[RED("waitForAnimEnd")] 
		public CBool WaitForAnimEnd
		{
			get => GetProperty(ref _waitForAnimEnd);
			set => SetProperty(ref _waitForAnimEnd, value);
		}

		public questCharacterWorkspot_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
