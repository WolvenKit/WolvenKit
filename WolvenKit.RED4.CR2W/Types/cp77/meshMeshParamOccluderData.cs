using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamOccluderData : meshMeshParameter
	{
		private CHandle<visIOccluderResource> _occluderResource;
		private CEnum<visWorldOccluderType> _defaultOccluderType;
		private CUInt8 _autoHideDistanceScale;

		[Ordinal(0)] 
		[RED("occluderResource")] 
		public CHandle<visIOccluderResource> OccluderResource
		{
			get
			{
				if (_occluderResource == null)
				{
					_occluderResource = (CHandle<visIOccluderResource>) CR2WTypeManager.Create("handle:visIOccluderResource", "occluderResource", cr2w, this);
				}
				return _occluderResource;
			}
			set
			{
				if (_occluderResource == value)
				{
					return;
				}
				_occluderResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("defaultOccluderType")] 
		public CEnum<visWorldOccluderType> DefaultOccluderType
		{
			get
			{
				if (_defaultOccluderType == null)
				{
					_defaultOccluderType = (CEnum<visWorldOccluderType>) CR2WTypeManager.Create("visWorldOccluderType", "defaultOccluderType", cr2w, this);
				}
				return _defaultOccluderType;
			}
			set
			{
				if (_defaultOccluderType == value)
				{
					return;
				}
				_defaultOccluderType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("autoHideDistanceScale")] 
		public CUInt8 AutoHideDistanceScale
		{
			get
			{
				if (_autoHideDistanceScale == null)
				{
					_autoHideDistanceScale = (CUInt8) CR2WTypeManager.Create("Uint8", "autoHideDistanceScale", cr2w, this);
				}
				return _autoHideDistanceScale;
			}
			set
			{
				if (_autoHideDistanceScale == value)
				{
					return;
				}
				_autoHideDistanceScale = value;
				PropertySet(this);
			}
		}

		public meshMeshParamOccluderData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
