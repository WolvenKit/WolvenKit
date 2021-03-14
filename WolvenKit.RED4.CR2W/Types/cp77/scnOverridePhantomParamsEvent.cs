using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverridePhantomParamsEvent : scnSceneEvent
	{
		private scnOverridePhantomParamsEventParams _params;

		[Ordinal(6)] 
		[RED("params")] 
		public scnOverridePhantomParamsEventParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnOverridePhantomParamsEventParams) CR2WTypeManager.Create("scnOverridePhantomParamsEventParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public scnOverridePhantomParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
