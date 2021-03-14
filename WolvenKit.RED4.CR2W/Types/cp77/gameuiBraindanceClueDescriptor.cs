using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBraindanceClueDescriptor : CVariable
	{
		private CEnum<gameuiEClueDescriptorMode> _mode;
		private CEnum<gameuiEBraindanceLayer> _layer;
		private CFloat _startTime;
		private CFloat _endTime;
		private CName _clueName;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameuiEClueDescriptorMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<gameuiEClueDescriptorMode>) CR2WTypeManager.Create("gameuiEClueDescriptorMode", "mode", cr2w, this);
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

		[Ordinal(1)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CEnum<gameuiEBraindanceLayer>) CR2WTypeManager.Create("gameuiEBraindanceLayer", "layer", cr2w, this);
				}
				return _layer;
			}
			set
			{
				if (_layer == value)
				{
					return;
				}
				_layer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get
			{
				if (_endTime == null)
				{
					_endTime = (CFloat) CR2WTypeManager.Create("Float", "endTime", cr2w, this);
				}
				return _endTime;
			}
			set
			{
				if (_endTime == value)
				{
					return;
				}
				_endTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get
			{
				if (_clueName == null)
				{
					_clueName = (CName) CR2WTypeManager.Create("CName", "clueName", cr2w, this);
				}
				return _clueName;
			}
			set
			{
				if (_clueName == value)
				{
					return;
				}
				_clueName = value;
				PropertySet(this);
			}
		}

		public gameuiBraindanceClueDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
