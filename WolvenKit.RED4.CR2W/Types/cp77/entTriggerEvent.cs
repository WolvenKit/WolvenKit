using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerEvent : redEvent
	{
		private entEntityID _triggerID;
		private entEntityGameInterface _activator;
		private Vector4 _worldPosition;
		private CUInt32 _numActivatorsInArea;
		private CUInt32 _activatorID;
		private CName _componentName;

		[Ordinal(0)] 
		[RED("triggerID")] 
		public entEntityID TriggerID
		{
			get => GetProperty(ref _triggerID);
			set => SetProperty(ref _triggerID, value);
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public entEntityGameInterface Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(3)] 
		[RED("numActivatorsInArea")] 
		public CUInt32 NumActivatorsInArea
		{
			get => GetProperty(ref _numActivatorsInArea);
			set => SetProperty(ref _numActivatorsInArea, value);
		}

		[Ordinal(4)] 
		[RED("activatorID")] 
		public CUInt32 ActivatorID
		{
			get => GetProperty(ref _activatorID);
			set => SetProperty(ref _activatorID, value);
		}

		[Ordinal(5)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		public entTriggerEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
