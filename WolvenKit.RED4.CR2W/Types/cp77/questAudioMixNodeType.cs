using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioMixNodeType : questIAudioNodeType
	{
		private CName _mixSignpost;

		[Ordinal(0)] 
		[RED("mixSignpost")] 
		public CName MixSignpost
		{
			get
			{
				if (_mixSignpost == null)
				{
					_mixSignpost = (CName) CR2WTypeManager.Create("CName", "mixSignpost", cr2w, this);
				}
				return _mixSignpost;
			}
			set
			{
				if (_mixSignpost == value)
				{
					return;
				}
				_mixSignpost = value;
				PropertySet(this);
			}
		}

		public questAudioMixNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
