using System;
namespace CalcCS.Expressions
{
    /// <summary>
    /// Операция возведения в степень
    /// </summary>
    class PowerOperation : BinaryOperation
    {
        /// <summary>
        /// Конструктор
        /// Обычно наследуется без изменений в классах конкретных операций.
        /// </summary>
        /// <param name="left">левый операнд</param>
        /// <param name="right">правый операнд</param>
        public PowerOperation(IExpression left, IExpression right) : base(left, right)
        { }
        public override double Calculate()
        {
            return Math.Pow(_left.Calculate(), _right.Calculate());
        }
    }
}
