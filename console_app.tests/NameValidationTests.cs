using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using console_app.library;

namespace console_app.tests.NameValidationTests
{
    [TestFixture]
    public class When_validating_user_name_and_name_has_a_number_in_it
    {
        [Test]
        public void should_say_name_is_invalid()
        {
            var name = "test_123";
            Assert.That(name.Validate(), Is.False);

            name = "123 name";
            Assert.That(name.Validate(), Is.False);

            name = "Thomas 123'Reilly";
            Assert.That(name.Validate(), Is.False);
        }
    }

    [TestFixture]
    public class When_validating_user_name_and_name_has_no_numbers_in_it
    {

        [Test]
        public void should_say_name_is_valid()
        {
            var name = "test_name";
            Assert.That(name.Validate(), Is.True);

            name = "test name";
            Assert.That(name.Validate(), Is.True);

            name = "Thomas O'Reilly";
            Assert.That(name.Validate(), Is.True);
        }
    }
}
