using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLookAtDrivenTurnsNode : questSignalStoppingNodeDefinition
	{
		private CEnum<questLookAtDrivenTurnsMode> _mode;
		private gameEntityReference _puppetRef;
		private CBool _canLookAtDrivenTurnsInterruptGesture;

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<questLookAtDrivenTurnsMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(3)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(4)] 
		[RED("canLookAtDrivenTurnsInterruptGesture")] 
		public CBool CanLookAtDrivenTurnsInterruptGesture
		{
			get => GetProperty(ref _canLookAtDrivenTurnsInterruptGesture);
			set => SetProperty(ref _canLookAtDrivenTurnsInterruptGesture, value);
		}

		public questLookAtDrivenTurnsNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
