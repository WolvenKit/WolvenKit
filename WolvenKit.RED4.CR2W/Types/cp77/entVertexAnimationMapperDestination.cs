using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapperDestination : CVariable
	{
		private CUInt32 _vertexCustomSlotIndex;

		[Ordinal(0)] 
		[RED("vertexCustomSlotIndex")] 
		public CUInt32 VertexCustomSlotIndex
		{
			get
			{
				if (_vertexCustomSlotIndex == null)
				{
					_vertexCustomSlotIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "vertexCustomSlotIndex", cr2w, this);
				}
				return _vertexCustomSlotIndex;
			}
			set
			{
				if (_vertexCustomSlotIndex == value)
				{
					return;
				}
				_vertexCustomSlotIndex = value;
				PropertySet(this);
			}
		}

		public entVertexAnimationMapperDestination(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
