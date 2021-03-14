using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSAnimationBufferBitwiseCompressedBoneTrack : CVariable
	{
		private animSAnimationBufferBitwiseCompressedData _position;
		private animSAnimationBufferBitwiseCompressedData _orientation;
		private animSAnimationBufferBitwiseCompressedData _scale;

		[Ordinal(0)] 
		[RED("position")] 
		public animSAnimationBufferBitwiseCompressedData Position
		{
			get
			{
				if (_position == null)
				{
					_position = (animSAnimationBufferBitwiseCompressedData) CR2WTypeManager.Create("animSAnimationBufferBitwiseCompressedData", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("orientation")] 
		public animSAnimationBufferBitwiseCompressedData Orientation
		{
			get
			{
				if (_orientation == null)
				{
					_orientation = (animSAnimationBufferBitwiseCompressedData) CR2WTypeManager.Create("animSAnimationBufferBitwiseCompressedData", "orientation", cr2w, this);
				}
				return _orientation;
			}
			set
			{
				if (_orientation == value)
				{
					return;
				}
				_orientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public animSAnimationBufferBitwiseCompressedData Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (animSAnimationBufferBitwiseCompressedData) CR2WTypeManager.Create("animSAnimationBufferBitwiseCompressedData", "scale", cr2w, this);
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

		public animSAnimationBufferBitwiseCompressedBoneTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
