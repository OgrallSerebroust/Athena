#ifndef ATHENANEWGENERATION_MAINWIDGET_H
#define ATHENANEWGENERATION_MAINWIDGET_H

#include <QWidget>
#include <QLabel>
#include <QHBoxLayout>
#include <QVBoxLayout>

class MainWidget : public QWidget {
    // TODO Возможно понадобится Q_OBJECT
public:
    explicit MainWidget(QWidget * parent = nullptr); // explicit Для того чтобы остановить неявные преобразования типов
    ~MainWidget() override;
private:
    QLabel *testLabel;
    QVBoxLayout *vbox1;
    QHBoxLayout *hbox1;
};

#endif //ATHENANEWGENERATION_MAINWIDGET_H
