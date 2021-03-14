using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netFramesInputsHistory : CVariable
	{
		private CArray<netFrameInputs> _frames;

		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<netFrameInputs> Frames
		{
			get
			{
				if (_frames == null)
				{
					_frames = (CArray<netFrameInputs>) CR2WTypeManager.Create("array:netFrameInputs", "frames", cr2w, this);
				}
				return _frames;
			}
			set
			{
				if (_frames == value)
				{
					return;
				}
				_frames = value;
				PropertySet(this);
			}
		}

		public netFramesInputsHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
