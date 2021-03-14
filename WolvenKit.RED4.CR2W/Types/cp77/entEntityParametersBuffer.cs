using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityParametersBuffer : CVariable
	{
		private CArray<serializationDeferredDataBuffer> _parameterBuffers;

		[Ordinal(0)] 
		[RED("parameterBuffers")] 
		public CArray<serializationDeferredDataBuffer> ParameterBuffers
		{
			get
			{
				if (_parameterBuffers == null)
				{
					_parameterBuffers = (CArray<serializationDeferredDataBuffer>) CR2WTypeManager.Create("array:serializationDeferredDataBuffer", "parameterBuffers", cr2w, this);
				}
				return _parameterBuffers;
			}
			set
			{
				if (_parameterBuffers == value)
				{
					return;
				}
				_parameterBuffers = value;
				PropertySet(this);
			}
		}

		public entEntityParametersBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
