using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetInteractionVisualizerOverride : questIInteractiveObjectManagerNodeType
	{
		private NodeRef _objectRef;
		private CBool _applyOverride;
		private CBool _removeAfterSingleUse;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("applyOverride")] 
		public CBool ApplyOverride
		{
			get => GetProperty(ref _applyOverride);
			set => SetProperty(ref _applyOverride, value);
		}

		[Ordinal(2)] 
		[RED("removeAfterSingleUse")] 
		public CBool RemoveAfterSingleUse
		{
			get => GetProperty(ref _removeAfterSingleUse);
			set => SetProperty(ref _removeAfterSingleUse, value);
		}

		public questSetInteractionVisualizerOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
