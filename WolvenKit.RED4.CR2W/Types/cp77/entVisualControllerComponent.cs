using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVisualControllerComponent : entIComponent
	{
		private rRef<CMesh> _meshProxy;
		private CArray<entVisualControllerDependency> _appearanceDependency;
		private raRef<appearanceCookedAppearanceData> _cookedAppearanceData;
		private CEnum<entVisualControllerComponentForcedLodDistance> _forcedLodDistance;

		[Ordinal(3)] 
		[RED("meshProxy")] 
		public rRef<CMesh> MeshProxy
		{
			get
			{
				if (_meshProxy == null)
				{
					_meshProxy = (rRef<CMesh>) CR2WTypeManager.Create("rRef:CMesh", "meshProxy", cr2w, this);
				}
				return _meshProxy;
			}
			set
			{
				if (_meshProxy == value)
				{
					return;
				}
				_meshProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("appearanceDependency")] 
		public CArray<entVisualControllerDependency> AppearanceDependency
		{
			get
			{
				if (_appearanceDependency == null)
				{
					_appearanceDependency = (CArray<entVisualControllerDependency>) CR2WTypeManager.Create("array:entVisualControllerDependency", "appearanceDependency", cr2w, this);
				}
				return _appearanceDependency;
			}
			set
			{
				if (_appearanceDependency == value)
				{
					return;
				}
				_appearanceDependency = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cookedAppearanceData")] 
		public raRef<appearanceCookedAppearanceData> CookedAppearanceData
		{
			get
			{
				if (_cookedAppearanceData == null)
				{
					_cookedAppearanceData = (raRef<appearanceCookedAppearanceData>) CR2WTypeManager.Create("raRef:appearanceCookedAppearanceData", "cookedAppearanceData", cr2w, this);
				}
				return _cookedAppearanceData;
			}
			set
			{
				if (_cookedAppearanceData == value)
				{
					return;
				}
				_cookedAppearanceData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forcedLodDistance")] 
		public CEnum<entVisualControllerComponentForcedLodDistance> ForcedLodDistance
		{
			get
			{
				if (_forcedLodDistance == null)
				{
					_forcedLodDistance = (CEnum<entVisualControllerComponentForcedLodDistance>) CR2WTypeManager.Create("entVisualControllerComponentForcedLodDistance", "forcedLodDistance", cr2w, this);
				}
				return _forcedLodDistance;
			}
			set
			{
				if (_forcedLodDistance == value)
				{
					return;
				}
				_forcedLodDistance = value;
				PropertySet(this);
			}
		}

		public entVisualControllerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
