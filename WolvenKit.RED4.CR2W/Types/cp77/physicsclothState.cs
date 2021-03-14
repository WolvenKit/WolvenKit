using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothState : CVariable
	{
		private physicsclothPhaseConfig _verticalPhaseData;
		private physicsclothPhaseConfig _horizontalPhaseData;
		private physicsclothPhaseConfig _bendPhaseData;
		private physicsclothPhaseConfig _shearPhaseData;
		private physicsclothRuntimeInfo _runtimeInfo;

		[Ordinal(0)] 
		[RED("verticalPhaseData")] 
		public physicsclothPhaseConfig VerticalPhaseData
		{
			get
			{
				if (_verticalPhaseData == null)
				{
					_verticalPhaseData = (physicsclothPhaseConfig) CR2WTypeManager.Create("physicsclothPhaseConfig", "verticalPhaseData", cr2w, this);
				}
				return _verticalPhaseData;
			}
			set
			{
				if (_verticalPhaseData == value)
				{
					return;
				}
				_verticalPhaseData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("horizontalPhaseData")] 
		public physicsclothPhaseConfig HorizontalPhaseData
		{
			get
			{
				if (_horizontalPhaseData == null)
				{
					_horizontalPhaseData = (physicsclothPhaseConfig) CR2WTypeManager.Create("physicsclothPhaseConfig", "horizontalPhaseData", cr2w, this);
				}
				return _horizontalPhaseData;
			}
			set
			{
				if (_horizontalPhaseData == value)
				{
					return;
				}
				_horizontalPhaseData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bendPhaseData")] 
		public physicsclothPhaseConfig BendPhaseData
		{
			get
			{
				if (_bendPhaseData == null)
				{
					_bendPhaseData = (physicsclothPhaseConfig) CR2WTypeManager.Create("physicsclothPhaseConfig", "bendPhaseData", cr2w, this);
				}
				return _bendPhaseData;
			}
			set
			{
				if (_bendPhaseData == value)
				{
					return;
				}
				_bendPhaseData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("shearPhaseData")] 
		public physicsclothPhaseConfig ShearPhaseData
		{
			get
			{
				if (_shearPhaseData == null)
				{
					_shearPhaseData = (physicsclothPhaseConfig) CR2WTypeManager.Create("physicsclothPhaseConfig", "shearPhaseData", cr2w, this);
				}
				return _shearPhaseData;
			}
			set
			{
				if (_shearPhaseData == value)
				{
					return;
				}
				_shearPhaseData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("runtimeInfo")] 
		public physicsclothRuntimeInfo RuntimeInfo
		{
			get
			{
				if (_runtimeInfo == null)
				{
					_runtimeInfo = (physicsclothRuntimeInfo) CR2WTypeManager.Create("physicsclothRuntimeInfo", "runtimeInfo", cr2w, this);
				}
				return _runtimeInfo;
			}
			set
			{
				if (_runtimeInfo == value)
				{
					return;
				}
				_runtimeInfo = value;
				PropertySet(this);
			}
		}

		public physicsclothState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
