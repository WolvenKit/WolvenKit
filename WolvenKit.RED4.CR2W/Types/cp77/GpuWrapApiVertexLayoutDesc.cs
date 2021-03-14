using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GpuWrapApiVertexLayoutDesc : CVariable
	{
		private CStatic<GpuWrapApiVertexPackingPackingElement> _elements;
		private CStatic<CUInt8> _slotStrides;
		private CUInt32 _slotMask;
		private CUInt32 _hash;

		[Ordinal(0)] 
		[RED("elements", 32)] 
		public CStatic<GpuWrapApiVertexPackingPackingElement> Elements
		{
			get
			{
				if (_elements == null)
				{
					_elements = (CStatic<GpuWrapApiVertexPackingPackingElement>) CR2WTypeManager.Create("static:32,GpuWrapApiVertexPackingPackingElement", "elements", cr2w, this);
				}
				return _elements;
			}
			set
			{
				if (_elements == value)
				{
					return;
				}
				_elements = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotStrides", 8)] 
		public CStatic<CUInt8> SlotStrides
		{
			get
			{
				if (_slotStrides == null)
				{
					_slotStrides = (CStatic<CUInt8>) CR2WTypeManager.Create("static:8,Uint8", "slotStrides", cr2w, this);
				}
				return _slotStrides;
			}
			set
			{
				if (_slotStrides == value)
				{
					return;
				}
				_slotStrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotMask")] 
		public CUInt32 SlotMask
		{
			get
			{
				if (_slotMask == null)
				{
					_slotMask = (CUInt32) CR2WTypeManager.Create("Uint32", "slotMask", cr2w, this);
				}
				return _slotMask;
			}
			set
			{
				if (_slotMask == value)
				{
					return;
				}
				_slotMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hash")] 
		public CUInt32 Hash
		{
			get
			{
				if (_hash == null)
				{
					_hash = (CUInt32) CR2WTypeManager.Create("Uint32", "hash", cr2w, this);
				}
				return _hash;
			}
			set
			{
				if (_hash == value)
				{
					return;
				}
				_hash = value;
				PropertySet(this);
			}
		}

		public GpuWrapApiVertexLayoutDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
