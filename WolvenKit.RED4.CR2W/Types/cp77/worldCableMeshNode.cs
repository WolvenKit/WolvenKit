using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCableMeshNode : worldBendedMeshNode
	{
		private CArrayFixedSize<CUInt64> _destructionHashes;
		private CFloat _cableLength;
		private CFloat _cableRadius;

		[Ordinal(13)] 
		[RED("destructionHashes", 2)] 
		public CArrayFixedSize<CUInt64> DestructionHashes
		{
			get
			{
				if (_destructionHashes == null)
				{
					_destructionHashes = (CArrayFixedSize<CUInt64>) CR2WTypeManager.Create("[2]Uint64", "destructionHashes", cr2w, this);
				}
				return _destructionHashes;
			}
			set
			{
				if (_destructionHashes == value)
				{
					return;
				}
				_destructionHashes = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("cableLength")] 
		public CFloat CableLength
		{
			get
			{
				if (_cableLength == null)
				{
					_cableLength = (CFloat) CR2WTypeManager.Create("Float", "cableLength", cr2w, this);
				}
				return _cableLength;
			}
			set
			{
				if (_cableLength == value)
				{
					return;
				}
				_cableLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("cableRadius")] 
		public CFloat CableRadius
		{
			get
			{
				if (_cableRadius == null)
				{
					_cableRadius = (CFloat) CR2WTypeManager.Create("Float", "cableRadius", cr2w, this);
				}
				return _cableRadius;
			}
			set
			{
				if (_cableRadius == value)
				{
					return;
				}
				_cableRadius = value;
				PropertySet(this);
			}
		}

		public worldCableMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
