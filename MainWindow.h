#ifndef ATHENANEWGENERATION_MAINWINDOW_H
#define ATHENANEWGENERATION_MAINWINDOW_H

#include "MainWidget.h"
#include <QMainWindow>

class MainWindow : public QMainWindow {
    // TODO Возможно понадобится Q_OBJECT
public:
    explicit MainWindow(QMainWindow * parent = nullptr); // explicit Для того чтобы остановить неявные преобразования типов
    ~MainWindow() override;
private:
    MainWidget *mainWidget;
};

#endif //ATHENANEWGENERATION_MAINWINDOW_H
