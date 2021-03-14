using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraTagEnemyLimitDataModule : GameSessionDataModule
	{
		private CInt32 _cameraLimit;
		private CArray<wCHandle<SurveillanceCamera>> _cameraList;

		[Ordinal(1)] 
		[RED("cameraLimit")] 
		public CInt32 CameraLimit
		{
			get
			{
				if (_cameraLimit == null)
				{
					_cameraLimit = (CInt32) CR2WTypeManager.Create("Int32", "cameraLimit", cr2w, this);
				}
				return _cameraLimit;
			}
			set
			{
				if (_cameraLimit == value)
				{
					return;
				}
				_cameraLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cameraList")] 
		public CArray<wCHandle<SurveillanceCamera>> CameraList
		{
			get
			{
				if (_cameraList == null)
				{
					_cameraList = (CArray<wCHandle<SurveillanceCamera>>) CR2WTypeManager.Create("array:whandle:SurveillanceCamera", "cameraList", cr2w, this);
				}
				return _cameraList;
			}
			set
			{
				if (_cameraList == value)
				{
					return;
				}
				_cameraList = value;
				PropertySet(this);
			}
		}

		public CameraTagEnemyLimitDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
