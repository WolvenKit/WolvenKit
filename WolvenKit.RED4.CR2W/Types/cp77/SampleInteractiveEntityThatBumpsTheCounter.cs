using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleInteractiveEntityThatBumpsTheCounter : gameObject
	{
		private NodeRef _targetEntityWithCounter;
		private gamePersistentID _targetPersistentID;

		[Ordinal(40)] 
		[RED("targetEntityWithCounter")] 
		public NodeRef TargetEntityWithCounter
		{
			get => GetProperty(ref _targetEntityWithCounter);
			set => SetProperty(ref _targetEntityWithCounter, value);
		}

		[Ordinal(41)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get => GetProperty(ref _targetPersistentID);
			set => SetProperty(ref _targetPersistentID, value);
		}

		public SampleInteractiveEntityThatBumpsTheCounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
