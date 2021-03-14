using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSensorObjectComponent : entIPlacedComponent
	{
		private CHandle<senseSensorObject> _sensorObject;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("sensorObject")] 
		public CHandle<senseSensorObject> SensorObject
		{
			get
			{
				if (_sensorObject == null)
				{
					_sensorObject = (CHandle<senseSensorObject>) CR2WTypeManager.Create("handle:senseSensorObject", "sensorObject", cr2w, this);
				}
				return _sensorObject;
			}
			set
			{
				if (_sensorObject == value)
				{
					return;
				}
				_sensorObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public senseSensorObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
