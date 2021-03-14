using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobMemoryLayout : CVariable
	{
		private CUInt32 _rowPitch;
		private CUInt32 _slicePitch;

		[Ordinal(0)] 
		[RED("rowPitch")] 
		public CUInt32 RowPitch
		{
			get
			{
				if (_rowPitch == null)
				{
					_rowPitch = (CUInt32) CR2WTypeManager.Create("Uint32", "rowPitch", cr2w, this);
				}
				return _rowPitch;
			}
			set
			{
				if (_rowPitch == value)
				{
					return;
				}
				_rowPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slicePitch")] 
		public CUInt32 SlicePitch
		{
			get
			{
				if (_slicePitch == null)
				{
					_slicePitch = (CUInt32) CR2WTypeManager.Create("Uint32", "slicePitch", cr2w, this);
				}
				return _slicePitch;
			}
			set
			{
				if (_slicePitch == value)
				{
					return;
				}
				_slicePitch = value;
				PropertySet(this);
			}
		}

		public rendRenderTextureBlobMemoryLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
