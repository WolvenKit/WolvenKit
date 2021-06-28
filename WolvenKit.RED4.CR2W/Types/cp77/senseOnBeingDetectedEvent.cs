using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseOnBeingDetectedEvent : redEvent
	{
		private wCHandle<senseSensorObject> _source;
		private CBool _isVisible;
		private TweakDBID _shapeId;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<senseSensorObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		[Ordinal(2)] 
		[RED("shapeId")] 
		public TweakDBID ShapeId
		{
			get => GetProperty(ref _shapeId);
			set => SetProperty(ref _shapeId, value);
		}

		public senseOnBeingDetectedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
