using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneDefaults : audioAudioMetadata
	{
		private CArray<audioAudSimpleParameter> _parameters;

		[Ordinal(1)] 
		[RED("parameters")] 
		public CArray<audioAudSimpleParameter> Parameters
		{
			get
			{
				if (_parameters == null)
				{
					_parameters = (CArray<audioAudSimpleParameter>) CR2WTypeManager.Create("array:audioAudSimpleParameter", "parameters", cr2w, this);
				}
				return _parameters;
			}
			set
			{
				if (_parameters == value)
				{
					return;
				}
				_parameters = value;
				PropertySet(this);
			}
		}

		public audioAudioSceneDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
