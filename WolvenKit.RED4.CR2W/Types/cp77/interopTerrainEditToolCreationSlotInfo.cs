using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainEditToolCreationSlotInfo : CVariable
	{
		private Vector2 _scale;
		private CBool _heightMappingOverrideEnable;
		private CFloat _heightMappingMin;
		private CFloat _heightMappingMax;

		[Ordinal(0)] 
		[RED("scale")] 
		public Vector2 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector2) CR2WTypeManager.Create("Vector2", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("heightMappingOverrideEnable")] 
		public CBool HeightMappingOverrideEnable
		{
			get
			{
				if (_heightMappingOverrideEnable == null)
				{
					_heightMappingOverrideEnable = (CBool) CR2WTypeManager.Create("Bool", "heightMappingOverrideEnable", cr2w, this);
				}
				return _heightMappingOverrideEnable;
			}
			set
			{
				if (_heightMappingOverrideEnable == value)
				{
					return;
				}
				_heightMappingOverrideEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("heightMappingMin")] 
		public CFloat HeightMappingMin
		{
			get
			{
				if (_heightMappingMin == null)
				{
					_heightMappingMin = (CFloat) CR2WTypeManager.Create("Float", "heightMappingMin", cr2w, this);
				}
				return _heightMappingMin;
			}
			set
			{
				if (_heightMappingMin == value)
				{
					return;
				}
				_heightMappingMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("heightMappingMax")] 
		public CFloat HeightMappingMax
		{
			get
			{
				if (_heightMappingMax == null)
				{
					_heightMappingMax = (CFloat) CR2WTypeManager.Create("Float", "heightMappingMax", cr2w, this);
				}
				return _heightMappingMax;
			}
			set
			{
				if (_heightMappingMax == value)
				{
					return;
				}
				_heightMappingMax = value;
				PropertySet(this);
			}
		}

		public interopTerrainEditToolCreationSlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
