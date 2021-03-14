using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDynamicMeshNode : worldMeshNode
	{
		private CBool _startAsleep;
		private CBool _isDebris;
		private CBool _initialGuess;
		private TrafficGenDynamicTrafficSetting _dynamicTrafficSetting;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(15)] 
		[RED("startAsleep")] 
		public CBool StartAsleep
		{
			get
			{
				if (_startAsleep == null)
				{
					_startAsleep = (CBool) CR2WTypeManager.Create("Bool", "startAsleep", cr2w, this);
				}
				return _startAsleep;
			}
			set
			{
				if (_startAsleep == value)
				{
					return;
				}
				_startAsleep = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isDebris")] 
		public CBool IsDebris
		{
			get
			{
				if (_isDebris == null)
				{
					_isDebris = (CBool) CR2WTypeManager.Create("Bool", "isDebris", cr2w, this);
				}
				return _isDebris;
			}
			set
			{
				if (_isDebris == value)
				{
					return;
				}
				_isDebris = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("initialGuess")] 
		public CBool InitialGuess
		{
			get
			{
				if (_initialGuess == null)
				{
					_initialGuess = (CBool) CR2WTypeManager.Create("Bool", "initialGuess", cr2w, this);
				}
				return _initialGuess;
			}
			set
			{
				if (_initialGuess == value)
				{
					return;
				}
				_initialGuess = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get
			{
				if (_dynamicTrafficSetting == null)
				{
					_dynamicTrafficSetting = (TrafficGenDynamicTrafficSetting) CR2WTypeManager.Create("TrafficGenDynamicTrafficSetting", "dynamicTrafficSetting", cr2w, this);
				}
				return _dynamicTrafficSetting;
			}
			set
			{
				if (_dynamicTrafficSetting == value)
				{
					return;
				}
				_dynamicTrafficSetting = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get
			{
				if (_navigationSetting == null)
				{
					_navigationSetting = (NavGenNavigationSetting) CR2WTypeManager.Create("NavGenNavigationSetting", "navigationSetting", cr2w, this);
				}
				return _navigationSetting;
			}
			set
			{
				if (_navigationSetting == value)
				{
					return;
				}
				_navigationSetting = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get
			{
				if (_useMeshNavmeshSettings == null)
				{
					_useMeshNavmeshSettings = (CBool) CR2WTypeManager.Create("Bool", "useMeshNavmeshSettings", cr2w, this);
				}
				return _useMeshNavmeshSettings;
			}
			set
			{
				if (_useMeshNavmeshSettings == value)
				{
					return;
				}
				_useMeshNavmeshSettings = value;
				PropertySet(this);
			}
		}

		public worldDynamicMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
