using System;
using NUnit.Framework;
using NUnit.VisualStudio.TestAdapter;
using NUnit;
using NUnit.Util.ProjectConverters;

using ru.itpc.trial.Data;

namespace ru.itpc.trial.test.Data
{
    [TestFixture]
    public class DefaultDataContextTest
    {
        [Test]
        public void DefaultDataContext_is_Singleton_test()
        {
            DataContext context = DefaultDataContext.Instance;
            DataContext contextCopy = DefaultDataContext.Instance;

            Assert.IsInstanceOf(typeof(StorageDataContext), context);

            Assert.AreSame(context, contextCopy);
        }
    }

    
}
