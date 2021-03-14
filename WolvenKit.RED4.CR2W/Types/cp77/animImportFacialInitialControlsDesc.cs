using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialInitialControlsDesc : CVariable
	{
		private CArray<CUInt16> _transformIds;
		private CArray<CName> _transformNames;
		private CArray<CUInt8> _transformRegions;

		[Ordinal(0)] 
		[RED("transformIds")] 
		public CArray<CUInt16> TransformIds
		{
			get
			{
				if (_transformIds == null)
				{
					_transformIds = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "transformIds", cr2w, this);
				}
				return _transformIds;
			}
			set
			{
				if (_transformIds == value)
				{
					return;
				}
				_transformIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transformNames")] 
		public CArray<CName> TransformNames
		{
			get
			{
				if (_transformNames == null)
				{
					_transformNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "transformNames", cr2w, this);
				}
				return _transformNames;
			}
			set
			{
				if (_transformNames == value)
				{
					return;
				}
				_transformNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transformRegions")] 
		public CArray<CUInt8> TransformRegions
		{
			get
			{
				if (_transformRegions == null)
				{
					_transformRegions = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "transformRegions", cr2w, this);
				}
				return _transformRegions;
			}
			set
			{
				if (_transformRegions == value)
				{
					return;
				}
				_transformRegions = value;
				PropertySet(this);
			}
		}

		public animImportFacialInitialControlsDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
