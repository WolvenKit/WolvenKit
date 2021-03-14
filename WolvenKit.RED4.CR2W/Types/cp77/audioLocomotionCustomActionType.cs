using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionCustomActionType : audioAudioMetadata
	{
		private CBool _void;

		[Ordinal(1)] 
		[RED("void")] 
		public CBool Void
		{
			get
			{
				if (_void == null)
				{
					_void = (CBool) CR2WTypeManager.Create("Bool", "void", cr2w, this);
				}
				return _void;
			}
			set
			{
				if (_void == value)
				{
					return;
				}
				_void = value;
				PropertySet(this);
			}
		}

		public audioLocomotionCustomActionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
