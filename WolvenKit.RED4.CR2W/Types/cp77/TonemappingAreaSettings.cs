using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TonemappingAreaSettings : IAreaSettings
	{
		private CHandle<ITonemappingMode> _mode;
		private CHandle<ITonemappingMode> _hdrMode;

		[Ordinal(2)] 
		[RED("mode")] 
		public CHandle<ITonemappingMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CHandle<ITonemappingMode>) CR2WTypeManager.Create("handle:ITonemappingMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hdrMode")] 
		public CHandle<ITonemappingMode> HdrMode
		{
			get
			{
				if (_hdrMode == null)
				{
					_hdrMode = (CHandle<ITonemappingMode>) CR2WTypeManager.Create("handle:ITonemappingMode", "hdrMode", cr2w, this);
				}
				return _hdrMode;
			}
			set
			{
				if (_hdrMode == value)
				{
					return;
				}
				_hdrMode = value;
				PropertySet(this);
			}
		}

		public TonemappingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
