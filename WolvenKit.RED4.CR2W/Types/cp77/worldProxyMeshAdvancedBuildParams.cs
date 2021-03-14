using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyMeshAdvancedBuildParams : CVariable
	{
		private worldProxyBoundingBoxSyncParams _boundingBoxSyncParams;
		private worldProxySurfaceFlattenParams _surfaceFlattenParams;
		private worldProxyMiscAdvancedParams _misc;
		private CFloat _rayBias;
		private CFloat _rayMaxDistance;

		[Ordinal(0)] 
		[RED("boundingBoxSyncParams")] 
		public worldProxyBoundingBoxSyncParams BoundingBoxSyncParams
		{
			get
			{
				if (_boundingBoxSyncParams == null)
				{
					_boundingBoxSyncParams = (worldProxyBoundingBoxSyncParams) CR2WTypeManager.Create("worldProxyBoundingBoxSyncParams", "boundingBoxSyncParams", cr2w, this);
				}
				return _boundingBoxSyncParams;
			}
			set
			{
				if (_boundingBoxSyncParams == value)
				{
					return;
				}
				_boundingBoxSyncParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("surfaceFlattenParams")] 
		public worldProxySurfaceFlattenParams SurfaceFlattenParams
		{
			get
			{
				if (_surfaceFlattenParams == null)
				{
					_surfaceFlattenParams = (worldProxySurfaceFlattenParams) CR2WTypeManager.Create("worldProxySurfaceFlattenParams", "surfaceFlattenParams", cr2w, this);
				}
				return _surfaceFlattenParams;
			}
			set
			{
				if (_surfaceFlattenParams == value)
				{
					return;
				}
				_surfaceFlattenParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("misc")] 
		public worldProxyMiscAdvancedParams Misc
		{
			get
			{
				if (_misc == null)
				{
					_misc = (worldProxyMiscAdvancedParams) CR2WTypeManager.Create("worldProxyMiscAdvancedParams", "misc", cr2w, this);
				}
				return _misc;
			}
			set
			{
				if (_misc == value)
				{
					return;
				}
				_misc = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rayBias")] 
		public CFloat RayBias
		{
			get
			{
				if (_rayBias == null)
				{
					_rayBias = (CFloat) CR2WTypeManager.Create("Float", "rayBias", cr2w, this);
				}
				return _rayBias;
			}
			set
			{
				if (_rayBias == value)
				{
					return;
				}
				_rayBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rayMaxDistance")] 
		public CFloat RayMaxDistance
		{
			get
			{
				if (_rayMaxDistance == null)
				{
					_rayMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "rayMaxDistance", cr2w, this);
				}
				return _rayMaxDistance;
			}
			set
			{
				if (_rayMaxDistance == value)
				{
					return;
				}
				_rayMaxDistance = value;
				PropertySet(this);
			}
		}

		public worldProxyMeshAdvancedBuildParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
