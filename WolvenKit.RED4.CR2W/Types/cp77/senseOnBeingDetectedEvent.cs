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
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<senseSensorObject>) CR2WTypeManager.Create("whandle:senseSensorObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shapeId")] 
		public TweakDBID ShapeId
		{
			get
			{
				if (_shapeId == null)
				{
					_shapeId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "shapeId", cr2w, this);
				}
				return _shapeId;
			}
			set
			{
				if (_shapeId == value)
				{
					return;
				}
				_shapeId = value;
				PropertySet(this);
			}
		}

		public senseOnBeingDetectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
