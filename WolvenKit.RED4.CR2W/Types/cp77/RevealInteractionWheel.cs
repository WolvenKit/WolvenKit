using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealInteractionWheel : redEvent
	{
		private wCHandle<gameObject> _lookAtObject;
		private CArray<CHandle<QuickhackData>> _commands;
		private CBool _shouldReveal;

		[Ordinal(0)] 
		[RED("lookAtObject")] 
		public wCHandle<gameObject> LookAtObject
		{
			get => GetProperty(ref _lookAtObject);
			set => SetProperty(ref _lookAtObject, value);
		}

		[Ordinal(1)] 
		[RED("commands")] 
		public CArray<CHandle<QuickhackData>> Commands
		{
			get => GetProperty(ref _commands);
			set => SetProperty(ref _commands, value);
		}

		[Ordinal(2)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get => GetProperty(ref _shouldReveal);
			set => SetProperty(ref _shouldReveal, value);
		}

		public RevealInteractionWheel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
